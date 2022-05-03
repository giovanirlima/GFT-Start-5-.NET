using System.Collections.Generic;
using System;
using RPGCsharp.Entities;


Hero hero = new Warrior(
    "Arus",
    42,
    800,
    750,
    "Knight"
    );

Hero oponnet = new Devil(
    "Maleficus",
    99,
    1300,
    750,
    "Devil"
    );

Hero wizard = new Wizard(
    "Jennica",
    42,
    790,
    1250,
    "White Mage"
    );



Console.WriteLine(hero);
Console.WriteLine();
Console.WriteLine(oponnet);
Console.WriteLine();
Console.WriteLine(wizard);
Console.WriteLine();
Console.WriteLine(hero.BasicAttack());
Console.WriteLine();
Console.WriteLine(oponnet.BasicAttack());
Console.WriteLine();
Console.WriteLine(wizard.BasicAttack());
Console.WriteLine();
Console.WriteLine(hero.ComboAttack(5));
Console.WriteLine();
Console.WriteLine(oponnet.ComboAttack(5));
Console.WriteLine();
Console.WriteLine(wizard.ComboAttack(5));
Console.WriteLine();
Console.WriteLine(hero.ComboAttack(11));
Console.WriteLine();
Console.WriteLine(oponnet.ComboAttack(11));
Console.WriteLine();
Console.WriteLine(wizard.ComboAttack(11));