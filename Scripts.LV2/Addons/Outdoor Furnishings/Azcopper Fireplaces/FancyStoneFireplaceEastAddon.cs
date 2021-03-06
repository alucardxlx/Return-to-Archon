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
	public class FancyStoneFireplaceEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FancyStoneFireplaceEastAddonDeed();
			}
		}

		[ Constructable ]
		public FancyStoneFireplaceEastAddon()
		{
			AddComponent( new AddonComponent( 5534 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 2557 ), 1, 2, 10 );
			AddComponent( new AddonComponent( 5534 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 2557 ), 1, -2, 10 );
			AddComponent( new AddonComponent( 1305 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 26 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 1997 ), 0, 2, 20 );
			AddComponent( new AddonComponent( 2232 ), -1, 3, 1 );
			AddComponent( new AddonComponent( 1305 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 29 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 1997 ), 0, 1, 20 );
			AddComponent( new AddonComponent( 7681 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2232 ), 0, 1, 1 );
			AddComponent( new AddonComponent( 1305 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 1997 ), 0, 0, 20 );
			AddComponent( new AddonComponent( 3562 ), 0, 0, 2 );
			AddComponent( new AddonComponent( 3561 ), 0, 0, 1 );
			AddComponent( new AddonComponent( 3553 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 7128 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 7682 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 5364 ), 0, 0, 21 );
			AddComponent( new AddonComponent( 3555 ), 0, 0, 2 );
			AddComponent( new AddonComponent( 2232 ), 0, 0, 1 );
			AddComponent( new AddonComponent( 1305 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 1997 ), 0, -1, 20 );
			AddComponent( new AddonComponent( 3562 ), 0, -1, 2 );
			AddComponent( new AddonComponent( 3561 ), 0, -1, 1 );
			AddComponent( new AddonComponent( 3553 ), 0, -1, 2 );
			AddComponent( new AddonComponent( 7128 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 7682 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 3555 ), 0, -1, 2 );
			AddComponent( new AddonComponent( 2232 ), 0, -1, 1 );
			AddComponent( new AddonComponent( 1305 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 27 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 1997 ), 0, -2, 20 );
			AddComponent( new AddonComponent( 28 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 28 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 29 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 27 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 27 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 27 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 27 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 27 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 1305 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 2231 ), 0, 3, 1 );
			AddComponent( new AddonComponent( 7138 ), 0, 3, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 27 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 29 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 2232 );
			AddComponent( ac, -1, 3, 1 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 26 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 27 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 29 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1997 );
			AddComponent( ac, 0, 2, 20 );
			ac = new AddonComponent( 1997 );
			AddComponent( ac, 0, 1, 20 );
			ac = new AddonComponent( 1997 );
			AddComponent( ac, 0, 0, 20 );
			ac = new AddonComponent( 1997 );
			AddComponent( ac, 0, -1, 20 );
			ac = new AddonComponent( 1997 );
			AddComponent( ac, 0, -2, 20 );
			ac = new AddonComponent( 3562 );
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 3562 );
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 3561 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 3561 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 3553 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 3553 );
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 7128 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 7128 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 28 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 7682 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 7682 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7681 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 5364 );
			AddComponent( ac, 0, 0, 21 );
			ac = new AddonComponent( 3555 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, -1, 2 );
			ac = new AddonComponent( 3555 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 2 );
			ac = new AddonComponent( 2232 );
			ac.Hue = 1893;
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 2232 );
			ac.Hue = 1893;
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 2232 );
			ac.Hue = 1893;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 2231 );
			AddComponent( ac, 0, 3, 1 );
			ac = new AddonComponent( 7138 );
			AddComponent( ac, 0, 3, 0 );

		}

		public FancyStoneFireplaceEastAddon( Serial serial ) : base( serial )
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

	public class FancyStoneFireplaceEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FancyStoneFireplaceEastAddon();
			}
		}

		[Constructable]
		public FancyStoneFireplaceEastAddonDeed()
		{
			Name = "FancyStoneFireplaceEast";
		}

		public FancyStoneFireplaceEastAddonDeed( Serial serial ) : base( serial )
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