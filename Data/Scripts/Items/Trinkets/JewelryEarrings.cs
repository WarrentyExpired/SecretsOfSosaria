using System;

namespace Server.Items
{
	public class JewelryEarrings : BaseTrinket
	{
		public override Catalogs DefaultCatalog{ get{ return Catalogs.Jewelry; } }

		[Constructable]
		public JewelryEarrings() : base( 0x672F )
		{
			Name = "earrings";
			Weight = 0.1;
			Layer = Layer.Earrings;
			WorldItemID = 7943;
		}

		public JewelryEarrings( Serial serial ) : base( serial )
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