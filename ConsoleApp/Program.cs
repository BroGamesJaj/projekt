List<int> lista = new List<int>();
int nszam = 1;
while(nszam != 0){
    Console.WriteLine("Kérem adjon meg egy számot a listához.(0 érték a végjel)");
    nszam = int.Parse(Console.ReadLine());
    if(nszam != 0){
        lista.Add(nszam);
    }
}
