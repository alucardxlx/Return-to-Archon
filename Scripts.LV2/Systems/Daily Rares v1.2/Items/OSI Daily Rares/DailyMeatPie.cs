using System;

namespace Server.Items
{
	public class DailyMeatPie : BaseDailyRareFood
	{
		public override int ArtifactRarity{ get{ return 0; } }
		
		[Constructable]
		public DailyMeatPie() : base( 0x1041 )
		{
			Name = "tasty meat pie";
			FillFactor = 5;
			Stackable = false;
		}

		public DailyMeatPie( Serial serial ) : base( serial )
		{
		}

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );
			list.Add( 1049644, "Daily Rare" );
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