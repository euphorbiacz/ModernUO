namespace Server.Mobiles
{
    public class SilverSteed : BaseMount
    {
        [Constructible]
        public SilverSteed(string name = "a silver steed") : base(name, 0x75, 0x3EA8, AIType.AI_Animal, FightMode.Aggressor)
        {
            SetSpeed(0.55, 1.1);

            InitStats(Utility.Random(50, 30), Utility.Random(50, 30), 10);
            Skills.MagicResist.Base = 25.0 + Utility.RandomDouble() * 5.0;
            Skills.Wrestling.Base = 35.0 + Utility.RandomDouble() * 10.0;
            Skills.Tactics.Base = 30.0 + Utility.RandomDouble() * 15.0;

            ControlSlots = 1;
            Tamable = true;
            MinTameSkill = 103.1;
        }

        public SilverSteed(Serial serial) : base(serial)
        {
        }

        public override string CorpseName => "a silver steed corpse";

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
