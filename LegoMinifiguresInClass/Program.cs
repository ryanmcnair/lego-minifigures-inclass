using System;
using LegoMinifiguresInClass.Pieces;
using LegoMinifiguresInClass.Pieces.Heads;
using LegoMinifiguresInClass.Pieces.Torsos;
using LegoMinifiguresInClass.Pieces.Legs;

namespace LegoMinifiguresInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.Eyewear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Female;

            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            var skull = new Skull { Color = Color.Red, Condition = Condition.Refurbished, EyeColor = Color.Green, Eyewear = "Aviators" };
            

            var heads = new Head[] { coolHead, nerdHead, skull };

            foreach (var head in heads)
            {
                
                head.Talk("Stuff");
            }

            var pirateWithHook = new PirateTorso(true) { Clothing = Clothing.Hoodie };
            var pirateWithoutHook = new PirateTorso(false) { Clothing = Clothing.Tanktop};

            pirateWithHook.Wave();
            pirateWithoutHook.Wave();

            var torso = new Torso { Clothing = Clothing.Hoodie, Color = Color.Green, NumberOfArms = 0 };

            var skeletonTorso = new SkeletonTorso(false, Condition.Broken);
            var policeTorso = new PoliceOfficerTorso();

            var torsos = new Torso[] { pirateWithHook, pirateWithoutHook, skeletonTorso, torso, policeTorso };

            foreach (var body in torsos)
            {
                body.Wave();
            }

            var legs = new DiscoLegs();

            var skullPoliceSpider = new Minifigure(skull, policeTorso, new SpiderLegs());
            skullPoliceSpider.MeetSomeone();
        }
    }
}
