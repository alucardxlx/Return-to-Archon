using System;
using Server.Items;
using Server.Targeting;

namespace Server.Engines.Craft
{
    public enum SmeltResult
    {
        Success,
        Invalid,
        NoSkill
    }

    public class Resmelt
    {
        public Resmelt()
        {
        }

        public static void Do(Mobile from, CraftSystem craftSystem, BaseTool tool)
        {
            int num = craftSystem.CanCraft(from, tool, null);

            if (num > 0 && num != 1044267)
            {
                from.SendGump(new CraftGump(from, craftSystem, tool, num));
            }
            else
            {
                from.Target = new InternalTarget(craftSystem, tool);
                from.SendLocalizedMessage(1044273); // Target an item to recycle.
            }
        }

        private class InternalTarget : Target
        {
            private readonly CraftSystem m_CraftSystem;
            private readonly BaseTool m_Tool;
            public InternalTarget(CraftSystem craftSystem, BaseTool tool)
                : base(2, false, TargetFlags.None)
            {
                this.m_CraftSystem = craftSystem;
                this.m_Tool = tool;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                int num = this.m_CraftSystem.CanCraft(from, this.m_Tool, null);

                if (num > 0)
                {
                    if (num == 1044267)
                    {
                        bool anvil, forge;
			
                        DefBlacksmithy.CheckAnvilAndForge(from, 2, out anvil, out forge);

                        if (!anvil)
                            num = 1044266; // You must be near an anvil
                        else if (!forge)
                            num = 1044265; // You must be near a forge.
                    }
					
                    from.SendGump(new CraftGump(from, this.m_CraftSystem, this.m_Tool, num));
                }
                else
                {
                    SmeltResult result = SmeltResult.Invalid;
                    bool isStoreBought = false;
                    int message;

                    if (targeted is BaseArmor)
                    {
                        result = this.Resmelt(from, (BaseArmor)targeted, ((BaseArmor)targeted).Resource);
                        isStoreBought = !((BaseArmor)targeted).PlayerConstructed;
                    }
                    else if (targeted is BaseWeapon)
                    {
                        result = this.Resmelt(from, (BaseWeapon)targeted, ((BaseWeapon)targeted).Resource);
                        isStoreBought = !((BaseWeapon)targeted).PlayerConstructed;
                    }
                    else if (targeted is DragonBardingDeed)
                    {
                        result = this.Resmelt(from, (DragonBardingDeed)targeted, ((DragonBardingDeed)targeted).Resource);
                        isStoreBought = false;
                    }

                    switch ( result )
                    {
                        default:
                        case SmeltResult.Invalid:
                            message = 1044272;
                            break; // You can't melt that down into ingots.
                        case SmeltResult.NoSkill:
                            message = 1044269;
                            break; // You have no idea how to work this metal.
                        case SmeltResult.Success:
                            message = isStoreBought ? 500418 : 1044270;
                            break; // You melt the item down into ingots.
                    }
					
                    from.SendGump(new CraftGump(from, this.m_CraftSystem, this.m_Tool, message));
                }
            }

            private SmeltResult Resmelt(Mobile from, Item item, CraftResource resource)
            {
                try
                {
                    if (Ethics.Ethic.IsImbued(item))
                        return SmeltResult.Invalid;

                    if (CraftResources.GetType(resource) != CraftResourceType.Metal)
                        return SmeltResult.Invalid;

                    CraftResourceInfo info = CraftResources.GetInfo(resource);

                    if (info == null || info.ResourceTypes.Length == 0)
                        return SmeltResult.Invalid;

                    CraftItem craftItem = this.m_CraftSystem.CraftItems.SearchFor(item.GetType());

                    if (craftItem == null || craftItem.Resources.Count == 0)
                        return SmeltResult.Invalid;

                    CraftRes craftResource = craftItem.Resources.GetAt(0);

                    if (craftResource.Amount < 2)
                        return SmeltResult.Invalid; // Not enough metal to resmelt

                    //daat99 OWLTR start - smelting difficulty
					double difficulty = daat99.ResourceHelper.GetMinSkill(resource);
					//daat99 OWLTR end - smelting difficulty

                    if (difficulty > from.Skills[SkillName.Mining].Value)
                        return SmeltResult.NoSkill;

                    Type resourceType = info.ResourceTypes[0];
                    Item ingot = (Item)Activator.CreateInstance(resourceType);

                    if (item is DragonBardingDeed || (item is BaseArmor && ((BaseArmor)item).PlayerConstructed) || (item is BaseWeapon && ((BaseWeapon)item).PlayerConstructed) || (item is BaseClothing && ((BaseClothing)item).PlayerConstructed))
                        ingot.Amount = craftResource.Amount / 2;
                    else
                        ingot.Amount = 1;

                    item.Delete();
                    from.AddToBackpack(ingot);

                    from.PlaySound(0x2A);
                    from.PlaySound(0x240);
                    return SmeltResult.Success;
                }
                catch
                {
                }

                return SmeltResult.Invalid;
            }
        }
    }
}