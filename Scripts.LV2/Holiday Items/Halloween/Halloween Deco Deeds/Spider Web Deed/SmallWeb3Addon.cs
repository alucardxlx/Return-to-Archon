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
	public class SmallWeb3Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmallWeb3AddonDeed();
			}
		}

		[ Constructable ]
		public SmallWeb3Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4308 );
			AddComponent( ac, 0, 0, 0 );

		}

		public SmallWeb3Addon( Serial serial ) : base( serial )
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

	public class SmallWeb3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmallWeb3Addon();
			}
		}

		[Constructable]
		public SmallWeb3AddonDeed()
		{
			Name = "SmallWeb3";
		}

		public SmallWeb3AddonDeed( Serial serial ) : base( serial )
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