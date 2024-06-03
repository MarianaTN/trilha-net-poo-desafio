using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123456789", "Nokia 3310", "111222333444555", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("123458967", "Iphone 15", "11122239329555", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Samsung samsung = new Samsung("023458967", "S20 FE", "1153533444550", 128);
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Telegram");
