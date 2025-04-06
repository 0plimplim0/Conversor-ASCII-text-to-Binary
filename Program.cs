Dictionary<char, string> asciiABinario = new Dictionary<char, string>(){
    { ' ', "00100000" },{ '0', "00110000" },{ '1', "00110001" },
    { '2', "00110010" },{ '3', "00110011" },{ '4', "00110100" },
    { '5', "00110101" },{ '6', "00110110" },{ '7', "00110111" },
    { '8', "00111000" },{ '9', "00111001" },{ 'A', "01000001" },
    { 'B', "01000010" },{ 'C', "01000011" },{ 'D', "01000100" },
    { 'E', "01000101" },{ 'F', "01000110" },{ 'G', "01000111" },
    { 'H', "01001000" },{ 'I', "01001001" },{ 'J', "01001010" },
    { 'K', "01001011" },{ 'L', "01001100" },{ 'M', "01001101" },
    { 'N', "01001110" },{ 'O', "01001111" },{ 'P', "01010000" },
    { 'Q', "01010001" },{ 'R', "01010010" },{ 'S', "01010011" },
    { 'T', "01010100" },{ 'U', "01010101" },{ 'V', "01010110" },
    { 'W', "01010111" },{ 'X', "01011000" },{ 'Y', "01011001" },
    { 'Z', "01011010" },{ 'a', "01100001" },{ 'b', "01100010" },
    { 'c', "01100011" },{ 'd', "01100100" },{ 'e', "01100101" },
    { 'f', "01100110" },{ 'g', "01100111" },{ 'h', "01101000" },
    { 'i', "01101001" },{ 'j', "01101010" },{ 'k', "01101011" },
    { 'l', "01101100" },{ 'm', "01101101" },{ 'n', "01101110" },
    { 'o', "01101111" },{ 'p', "01110000" },{ 'q', "01110001" },
    { 'r', "01110010" },{ 's', "01110011" },{ 't', "01110100" },
    { 'u', "01110101" },{ 'v', "01110110" },{ 'w', "01110111" },
    { 'x', "01111000" },{ 'y', "01111001" },{ 'z', "01111010" },
    { '(', "00101000" },{ ')', "00101001" },{ ',', "00101100" }
};

Dictionary<string, char> binarioAAscii = new Dictionary<string, char>(){
    { "00100000", ' ' },{ "00110000", '0' },{ "00110001", '1' },
    { "00110010", '2' },{ "00110011", '3' },{ "00110100", '4' },
    { "00110101", '5' },{ "00110110", '6' },{ "00110111", '7' },
    { "00111000", '8' },{ "00111001", '9' },{ "01000001", 'A' },
    { "01000010", 'B' },{ "01000011", 'C' },{ "01000100", 'D' },
    { "01000101", 'E' },{ "01000110", 'F' },{ "01000111", 'G' },
    { "01001000", 'H' },{ "01001001", 'I' },{ "01001010", 'J' },
    { "01001011", 'K' },{ "01001100", 'L' },{ "01001101", 'M' },
    { "01001110", 'N' },{ "01001111", 'O' },{ "01010000", 'P' },
    { "01010001", 'Q' },{ "01010010", 'R' },{ "01010011", 'S' },
    { "01010100", 'T' },{ "01010101", 'U' },{ "01010110", 'V' },
    { "01010111", 'W' },{ "01011000", 'X' },{ "01011001", 'Y' },
    { "01011010", 'Z' },{ "01100001", 'a' },{ "01100010", 'b' },
    { "01100011", 'c' },{ "01100100", 'd' },{ "01100101", 'e' },
    { "01100110", 'f' },{ "01100111", 'g' },{ "01101000", 'h' },
    { "01101001", 'i' },{ "01101010", 'j' },{ "01101011", 'k' },
    { "01101100", 'l' },{ "01101101", 'm' },{ "01101110", 'n' },
    { "01101111", 'o' },{ "01110000", 'p' },{ "01110001", 'q' },
    { "01110010", 'r' },{ "01110011", 's' },{ "01110100", 't' },
    { "01110101", 'u' },{ "01110110", 'v' },{ "01110111", 'w' },
    { "01111000", 'x' },{ "01111001", 'y' },{ "01111010", 'z' },
    { "00101000", '(' },{ "00101001", ')' },{ "00101100", ',' }
};

List<string> ConvertirABinario(string texto){
    List<string> textoBinario =  new List<string>();
    foreach (char character in texto){
        if (asciiABinario.ContainsKey(character)){
            textoBinario.Add(asciiABinario[character]);
        }
        else {
            textoBinario.Add("????????");
        }
    }

    return textoBinario;
}

List<char> ConvertirAAscii(string texto){
    List<char> textoAscii = new List<char>();
    List<string> textoBinario = new List<string>();
    for (int i = 0; i < texto.Length; i += 8){
        if (i + 8 <= texto.Length){
            textoBinario.Add(texto.Substring(i, 8));
        }
    }

    foreach (string character in textoBinario){
        if (binarioAAscii.ContainsKey(character)){
            textoAscii.Add(binarioAAscii[character]);
        }
        else {
            textoAscii.Add('?');
        }
    }

    return textoAscii;
}

while (true){
    Console.Clear();
    
    Console.WriteLine("Proyecto: Conversor a codigo binario\nVersion: Beta");
    Console.WriteLine("\n===================\n     Comandos\n===================\n1. ASCII a Binario.\n2. Binario a ASCII.\n3. Salir.\n");
    Console.Write("Comando: ");
    string userCommand = Console.ReadLine();

    if (userCommand == "1"){
        Console.Write("Introduce el texto ASCII: ");
        string textoAscii = Console.ReadLine();
        List<string> textoBinario = ConvertirABinario(textoAscii);
        Console.WriteLine("El texto proporcionado traducido a binario es:");
        Console.WriteLine(string.Join("", textoBinario));
        Console.Write("\nPresiona ENTER para volver.");
        Console.Read();
    }
    else if (userCommand == "2"){
        Console.Write("Introduce el texto binario: ");
        string textoBinario = Console.ReadLine();
        List<char> textoAscii = ConvertirAAscii(textoBinario);
        Console.WriteLine("El texto proporcionado traducido a ASCII es:");
        Console.WriteLine(string.Join("", textoAscii));
        Console.Write("\nPresiona ENTER para volver.");
        Console.Read();
    }
    else if (userCommand == "3"){
        Console.WriteLine("Saliendo...");
        Thread.Sleep(500);
        break;
    }
    else {

        Console.WriteLine("Comando invalido. Por favor introduce uno valido.");
        Thread.Sleep(1500);
    }
}