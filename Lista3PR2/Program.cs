using System;

class Program
{
    public static void Main(string[] args)
    {
       ;

int num;

Console.WriteLine("=====MENU=====");
Console.WriteLine("1- Exercício 1");
Console.WriteLine("2- Exercício 2");
Console.WriteLine("3- Exercício 3");
Console.WriteLine("4- Exercício 4");
Console.WriteLine("5- Exercício 5");
Console.WriteLine("6- Exercício 6");
Console.WriteLine("Digite a opção desejada: ");

num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                int d;
                Console.WriteLine("Digite um número de 1-7: ");
                d = int.Parse(Console.ReadLine());

                switch (d)
                {
                    case 1:

                        Console.WriteLine("Exercício 1...");
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda-Feira");
                        break;
                    case 3:
                        Console.WriteLine("Terça-Feira");
                        break;
                    case 4:
                        Console.WriteLine("Quarta-Feira");
                        break;
                    case 5:
                        Console.WriteLine("Quinta-Feira");
                        break;
                    case 6:
                        Console.WriteLine("Sexta-Feira");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;

                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
                break;
                Console.ReadKey();

            case 2:
                Console.WriteLine("Exercício 2...");
                float v, vT, n;

                Console.WriteLine("===Menu===");
                Console.WriteLine("1- à vista");
                Console.WriteLine("2- PIX");
                Console.WriteLine("3- Débito");
                Console.WriteLine("4- Cartão de Crédito");
                Console.WriteLine("Digite o valor de compra: ");

                v = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a opção desejada: ");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        vT = ((15 / 100) * v) - v;
                        Console.WriteLine("O valor total é de R$" + vT);
                        break;
                    case 2:
                        vT = ((10 / 10) * v) - v;
                        Console.WriteLine("O valor total é de R$" + vT);
                        break;
                    case 3:
                        vT = ((5 / 100) * v) + v;
                        Console.WriteLine("O valor total é de R$" + vT);
                        break;
                    case 4:
                        vT = ((10 / 100) * v) + v;
                        Console.WriteLine("O valor total é de R$" + vT);
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
                break;
                Console.ReadKey();

            case 3:
                Console.WriteLine("Exercício 3...");
                int ano, mes;

                Console.WriteLine("Digite o ano: ");
                ano = int.Parse(Console.ReadLine());

                Console.WriteLine("===Menu===");
                Console.WriteLine("1- Janeiro");
                Console.WriteLine("2- Fevereiro");
                Console.WriteLine("3- Março");
                Console.WriteLine("4- Abril");
                Console.WriteLine("5- Maio");
                Console.WriteLine("6- Junho");
                Console.WriteLine("7- Julho");
                Console.WriteLine("8- Agosto");
                Console.WriteLine("9- Setembro");
                Console.WriteLine("10- Outubro");
                Console.WriteLine("11- Novembro");
                Console.WriteLine("12- Dezembro");
                Console.WriteLine("Digite o mês: ");

                mes = int.Parse(Console.ReadLine());

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro possui 31 dias.");
                        break;
                    case 2:
                        if (ano % 4 == 0)
                        {
                            Console.WriteLine("Fevereiro possui 29 dias.");
                        }
                        else
                        {
                            Console.WriteLine("Fevereiro possui 28 dias.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Março possui 31 dias.");
                        break;
                    case 4:
                        Console.WriteLine("Abril possui 30 dias.");
                        break;
                    case 5:
                        Console.WriteLine("Maio possui 31 dias.");
                        break;
                    case 6:
                        Console.WriteLine("Junho possui 30 dias.");
                        break;
                    case 7:
                        Console.WriteLine("Julho possui 31 dias.");
                        break;
                    case 8:
                        Console.WriteLine("Agosto possui 31 dias.");
                        break;
                    case 9:
                        Console.WriteLine("Setembro possui 30 dias.");
                        break;
                    case 10:
                        Console.WriteLine("Outubro possui 31 dias.");
                        break;
                    case 11:
                        Console.WriteLine("Novembro possui 30 dias.");
                        break;
                    case 12:
                        Console.WriteLine("Dezembro possui 31 dias.");
                        break;
                }
                break;
                Console.ReadKey();

            case 4:
                Console.WriteLine("Exercício 4...");

                int n1, n2, op, result;
                double result2;

                Console.WriteLine("Digite o primeiro valor: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segndo valor: ");
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine("====Operações====");
                Console.WriteLine("1- +");
                Console.WriteLine("2- -");
                Console.WriteLine("3- *");
                Console.WriteLine("4- /");
                Console.WriteLine("5- ^");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        result = n1 + n2;
                        Console.WriteLine("O resultado da operaçaõ é de " + result);
                        break;

                    case 2:
                        result = n1 - n2;
                        Console.WriteLine("O resultado da operaçaõ é de " + result);
                        break;

                    case 3:
                        result = n1 * n2;
                        Console.WriteLine("O resultado da operaçaõ é de " + result);
                        break;
                    case 4:
                        result = n1 / n2;
                        Console.WriteLine("O resultado da operaçaõ é de " + result);
                        break;
                    case 5:
                        result2 = Math.Pow(n1, n2);
                        Console.WriteLine("O resultado da operaçaõ é de " + result2);
                        break;

                    default:
                        Console.WriteLine("Valor Inválido");
                        break;
                }
                Console.ReadKey();
                break;



            case 5:
                Console.WriteLine("Exercício 5...");

                float sl, df, sla;
                int cg;

                Console.WriteLine("Digite seu salário atual :");
                sl = float.Parse(Console.ReadLine());

                Console.WriteLine("====Cargo====");
                Console.WriteLine("1- Professor");
                Console.WriteLine("2- Secretário");
                Console.WriteLine("3- Publicitário");
                Console.WriteLine("4- Jornalista");
                Console.WriteLine("5- Mecânico");
                Console.WriteLine("6- Estagiário");
                Console.WriteLine("7- Técnico de TI");

                cg = int.Parse(Console.ReadLine());

                switch (cg)
                {
                    case 1:
                        sla = sl * 0.075f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;

                    case 2:
                        sla = sl * 0.097f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;

                    case 3:
                        sla = sl * 0.117f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;

                    case 4:
                        sla = sl * 0.089f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;

                    case 5:
                        sla = sl * 0.1324f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;

                    case 6:
                        sla = sl * 0.104f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;

                    case 7:
                        sla = sl * 0.146f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;





                    default:
                        sla = sl * 0.435f;
                        df = sl - sla;
                        Console.WriteLine("Seu novo Salário será de R$ " + sla + "E a diferença é de R$ " + df);
                        break;
                }
                Console.ReadKey();
                break;



            case 6:
                Console.WriteLine("Exercício 6...");
                double slm, slma, de;

                Console.WriteLine("Digite seu salário atual :");
                slm = float.Parse(Console.ReadLine());


                if (slm > 0 && slm <= 1904.98)
                {
                    Console.WriteLine("Insento de Imposto de Renda;");
                }
                else if (slm > 1904.99 && slm <= 2826.65)
                {
                    de = slm * 0.075;
                    slma = slm - de;
                    Console.WriteLine("Seu novo salárioserá de R$" + slma + "Retirando assim R$ " + de);
                }
                else if (slm > 2826.66 && slm <= 3751.05)
                {
                    de = slm * 0.15;
                    slma = slm - de;
                    Console.WriteLine("Seu novo salárioserá de R$" + slma + "Retirando assim R$ " + de);
                }
                else if (slm > 3751.06 && slm <= 4664.68)
                {
                    de = slm * 0.225;
                    slma = slm - de;
                    Console.WriteLine("Seu novo salárioserá de R$" + slma + "Retirando assim R$ " + de);
                }
                else if (slm > 4664.68)
                {
                    de = slm * 0.275;
                    slma = slm - de;
                    Console.WriteLine("Seu novo salárioserá de R$" + slma + "Retirando assim R$ " + de);
                }
                Console.ReadKey();
                break;

        }
    }
}
