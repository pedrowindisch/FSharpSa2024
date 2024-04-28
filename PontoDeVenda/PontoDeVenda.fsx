(*
    Vamos desenvolver um mini ponto de venda (PDV).

    Quem vai comandar o ponto de venda é um atendente. Na hora do pagamento, o PDV deve:
        - até que digitado "FINALIZAR":
            - até que digitado "SAIR": 
                - perguntar o item e a qtd. que ele está comprando:
                    - no caso do produto não existir, apresentar a mensagem "Item inexistente"
                    - caso contrário, adicionar o valor ao total do cliente (item.preco * qtd).
        - no fim, apresentar o valor final ao cliente, e salvar esse valor.
        - no fim, apresentar o valor final de todos os clientes: "Vendas do dia: R$..."

    A maior parte do código, incluindo assinaturas e alguma parte da implementação das funções necessárias, já se encontram abaixo. 

    Exemplo de resultado final:
    > Digite FINALIZAR, ou pressione qualquer tecla para continuar.


    > Digite o nome do produto ou SAIR
    suco

    > Quantidade?
    2

    > Digite o nome do produto ou SAIR
    aaaaa

    > Item inexistentte,
    > Digite o nome do produto ou SAIR
    SAIR

    > Total do cliente: R$ 9.00
    > Digite FINALIZAR, ou pressione qualquer tecla para continuar.
    FINALIZAR

    > Vendas do dia: R$ 9.00

*)

open System

let produtos = [
    ("refrigerante", 5.0);
    ("chá", 4);
    ("energético", 7);
    ("café", 3.5);
    ("água", 2.5);
    ("suco", 4.5);
]

let encontrarProduto nome =
    None // Alterar essa linha/a partir daqui

let iniciarVendasDoDia = 
    let rec iniciarPedidoCliente (somatorio: float) =
        printfn "Digite o nome do produto ou SAIR"
        let entrada = Console.ReadLine()

        0.0 // Alterar essa linha/a partir daqui

    let rec solicitarEntrada (somatorio: float) =
        printfn "Digite FINALIZAR, ou pressione qualquer tecla para continuar."
        let entrada = Console.ReadLine()

        0.0 // Alterar essa linha/a partir daqui

    solicitarEntrada 0.0


printfn "Olá!"
let valorFinal = iniciarVendasDoDia

printfn "Vendas do dia: R$ %.2f" valorFinal