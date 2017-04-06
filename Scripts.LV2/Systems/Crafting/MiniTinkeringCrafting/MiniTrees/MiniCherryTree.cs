using System;
using Server.Items;

namespace Server.Items
{
	public class MiniCherryTree : Item
	{
		[Constructable]
		public MiniCherryTree() : base( 0x3F0C )
		{
			Weight = 1.0;
			Name = "Mini Cherry Tree";
			Movable = true;
		}

		public MiniCherryTree( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}