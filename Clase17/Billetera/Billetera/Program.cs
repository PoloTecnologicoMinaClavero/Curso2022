using Billetera;

//var b1 = new Billetera.Billetera();
//var b2 = new Billetera.Billetera();
//b1.BilletesDe100 = 1;
//b2.BilletesDe1000 = 1;
//Console.WriteLine(b1.Total().ToString());
//Console.WriteLine(b2.Total().ToString());
//var b3 = b1.Combinar(b2);
//Console.WriteLine(b3.Total().ToString());


//var bc1 = new Billetera.Version2.BilleteraCarlos();
//var bc2 = new Billetera.Version2.BilleteraCarlos();
//bc1.BilletesDe100 = 1;
//bc2.BilletesDe1000 = 1;
//Console.WriteLine(bc1.Total().ToString());
//Console.WriteLine(bc2.Total().ToString());
//var bc3 = bc1.Combinar(bc2);
//Console.WriteLine(bc3.Total().ToString());


var b1 = new Billetera.Billetera();
var bc2 = new Billetera.Version2.BilleteraCarlos();
b1.BilletesDe100 = 1;
bc2.BilletesDe1000 = 1;
Console.WriteLine(b1.Total().ToString());
Console.WriteLine(bc2.Total().ToString());
IBilletera bc3 = b1.Combinar(bc2);
Console.WriteLine(bc3.Total().ToString());
