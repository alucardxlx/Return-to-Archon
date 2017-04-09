/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SkullPoleAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SkullPoleAddonDeed();
			}
		}

		[ Constructable ]
		public SkullPoleAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 8708 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SkullPoleAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SkullPoleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SkullPoleAddon();
			}
		}

		[Constructable]
		public SkullPoleAddonDeed()
		{
			Name = "SkullPole";
            
		}

		public SkullPoleAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}