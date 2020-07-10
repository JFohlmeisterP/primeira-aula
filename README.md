# Projeto Entra21


### Escrevendo e Lendo (Console)
    // Escrever
     Console.WriteLine("Qual a sua idade?");

    //Ler e salvar o resultado
    var result = Console.ReadLine();


### Declarando Variáveis e Constantes

    var text = "meu texto";
    string text = "meu texto";
    const string text = "meu texto";


### Tipos Básicos

    // Numérico
    var number = 1;

    // Texto/String
    var text = "";

    // Booleano/Bool
    var boolean = true/false;

    // Numérico com ponto flutuante/double
    var price = 4.099;

    // Numérico
    var number = 1;

    // Data/DateTime
    var currentDate = DateTime.Now;

### Parsers/ Transformadores
    // Transformar um texto/string em um número/int
    var userAge = Int32.Parse(result);

### Operadores de Comparação
#### (toda comparação retorna um booleano/bool)
    // Igual
    1 == 1;
    // retorna true

    // Diferente
    1 != 1;
    // retorna false

    // Negação
    !(1 == 1);
    // retorna false

    // Maior
    2 > 1;
    // retorna true

    // Menor
    5 < 8;
    // retorna true

    // Maior/Menor OU Igual
    7 >= 7;
    // retorna true

    // Maior
    !(1 == 1);
    // retorna false

    // E
    true && true;
    // retorna true

    // OU
    false || true;
    // retorna true

### Operadores Matemáticos

    // Somar
    1 + 2;

    // Subtrair
    5 - 1;

    // Multiplicar
    3 * 5;

    // Dividir
    10 / 2;

    // Resto
    3 % 2;

### Comandos do Editor

    // Selecionando o texto:
    SHIFT + setas

    // Comentar:
    Ctrl + K + C

    // Desfazer comentário:
    Ctrl + K + U

    // Refazer:
    Ctrl + y

    // Abrir Teerminal
    Ctrl + '


### Depurando a Aplicação

1. Clicar em debug(barata) e depois botão de engrenagem

2. Selecionar o texto '.Net Core'

3. Alterar a opção Console para IntegratedTerminal (launch.json)

4. Add quantos breakpoints quiser (esquerda da linha)

5. Clicar barata e de pois Start (verdinho)

6. Selecionar o Terminal (Sair na tab "Debug Console"

7. F10 vai para a próxima linha 

8. F5 vai para o próximo breakpoint

9. Shift + F5 para "matar" a aplicação

10. Ctrl + Shift + F5 para reiniciar o debug


### Blocos Condicionais

    // IF (Se)

    Exemplo: 

    Escrever Olá SOMENTE se 1 > 0
    if (1 > 0);
    {
        Console.WriteLine("Olá!");
    }
    // Caso 1 NÃO seja maior que 0 e 2 > 1, escreva Boa tarde!
    else if
    {
        Console.WriteLine("Boa tarde!");
    }
    // Caso 1 NÃO seja maior que 0 e 2 > 1, escreva Boa tarde!
    else
    {
        Console.WriteLine("Xau!");
    }
    
    
    






    







    


