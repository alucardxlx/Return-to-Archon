using System;
using Server.Items;

namespace Server.Items
{
	public class MiniCarpetBlueG : Item
	{
		[Constructable]
		public MiniCarpetBlueG() : base( 0x3F09 )
		{
			Weight = 1.0;
			Name = "Mini Carpet Blue Gold";
			Movable = true;
		}

		public MiniCarpetBlueG( Serial serial ) : base( serial )
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