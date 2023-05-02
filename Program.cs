
/*Sistema de pagamento de uma loja virtual

* criar as classes de acordo com o diagrama de classes UML disponibilizado.

* o programa deve ter um menu com as seguintes opções:
- pagamento em boleto
- pagamento em cartão de crédito
- pagamento em cartão de débito
- cancelar operação
- sair do sistema

* o usuário deve informar o valor da compra.
* o sistema deverá calcular e exibir o valor a ser pago conforme as regras de negócio
descrito no diagrama.

- Boleto :
- desconto de 12%
- deverá exibir o código de barras do boleto junto com o valor a ser pago

- Crédito :
- limite estabelecido no cartão de crédito deve ser pré-definido
- máximo de parcelamento 12x
- até 6x - acrescentar juros de 5% no valor da compra
- entre 7x e 12x acrescentar juros de 8% no valor da compra

- Débito : valor á vista sem desconto
- valor do saldo em conta deve ser pré-definido
*/





Console.WriteLine(@$"



-----------------------------------------
|          |Programa de Pagamento|      | 
|                                       |
|        *escolha uma das opcoes*       |
|     1.Pagamento em Boleto             | 
|     2.Pagamento em Cartao de Credito  |                         
|     3.Pagamento em Cartao de Debito   |
|     4.Cancelar operacao               |
|     0.Sair                            |
-----------------------------------------


");



Console.WriteLine($"escolha uma opcao!");
string opcao = Console.ReadLine();

float ValordaCompra;
float limite=500.00f;





switch (opcao)
{
    case "1":

        Console.WriteLine($"voce escolheu a opcao pagamento em boleto!");


        break;


    case "2":

        Console.WriteLine($"voce escolheu a opcao pagamento em cartao de credito!");


        break;


    case "3":

        Console.WriteLine($"voce escolheu a opcao pagamento em cartao de debito!");


        break;


    case "4":



        Console.WriteLine($"voce escolheu a opcao cancelar");


        break;




    case "0":

        Console.WriteLine($"voce escolheu ao opcao sair");


        break;



}
   
        
      
       
Console.WriteLine($"o seu limite e de:{limite}");


        Console.WriteLine($"Digite o valor da compra:");
        ValordaCompra = float.Parse(Console.ReadLine());


        float saldo = limite - ValordaCompra;

        
        if (ValordaCompra > limite)
        {


            Console.WriteLine($"Saldo Insulficiente");


        }

        else
        {

            Console.WriteLine($"Compra realizada com sucesso!");

            Console.WriteLine($"o Seu saldo restante é de R$:{saldo}");
            
        }








