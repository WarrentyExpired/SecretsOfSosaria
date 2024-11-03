using System;
using Server;
using Server.Spells.Second;
using Server.Targeting;

namespace Server.Items
{
	public class HarmMagicStaff : BaseMagicStaff
	{
		[Constructable]
		public HarmMagicStaff() : base( MagicStaffEffect.Charges, 1, 20 )
		{
			IntRequirement = 15;
			SkillBonuses.SetValues( 1, SkillName.Magery, 20 );
		}

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );
			list.Add( 1070722, "2nd Circle of Power" );
		}

		public HarmMagicStaff( Serial serial ) : base( serial )
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

		public override void OnMagicStaffUse( Mobile from )
		{
			Cast( new HarmSpell( from, this ) );
		}
	}
}