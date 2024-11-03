using System;
using Server;
using Server.Spells.Seventh;
using Server.Targeting;

namespace Server.Items
{
	public class MeteorSwarmMagicStaff : BaseMagicStaff
	{
		[Constructable]
		public MeteorSwarmMagicStaff() : base( MagicStaffEffect.Charges, 1, 5 )
		{
			IntRequirement = 45;
			Name = "wand of meteor swarms";
			SkillBonuses.SetValues( 1, SkillName.Magery, 70 );
		}

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );
			list.Add( 1070722, "7th Circle of Power" );
		}

		public MeteorSwarmMagicStaff( Serial serial ) : base( serial )
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
			Cast( new MeteorSwarmSpell( from, this ) );
		}
	}
}