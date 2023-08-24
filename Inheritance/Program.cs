
using Inheritance;

Radio myRadio = new Radio(false, "Sony");
myRadio.SwitchOn();
myRadio.ListenRadio();

TV myTV = new TV(false, "LG");
myTV.SwitchOn();
myTV.WatchingTV();

Console.ReadLine();
