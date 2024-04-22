(*
    Altere a função retornaIniciadosPorVogal para que o resultado dela
    seja todos os valores dentro da lista nos quais iniciam por uma vogal.

    Existem várias formas de se resolver esse problema. Tenha em mente que lista são imutáveis, então não é possível
    adicionar ou remover elementos de uma lista após ela ter sido criada.

    Sugestão de leitura:
        - List.filter
          https://fsharp.github.io/fsharp-core-docs/reference/fsharp-collections-listmodule.html#filter

        - List.contains
          https://fsharp.github.io/fsharp-core-docs/reference/fsharp-collections-listmodule.html#contains

        - String indexing
          https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/strings#string-indexing-and-slicing
*)

open System

let vogais = ['A'; 'E'; 'I'; 'O'; 'U']

let retornaIniciadosPorVogal (lista: string list) =
    (* Mude a partir daqui. Pode remover as chaves abaixo. *)
    [""]

let nomes = [
    "Agatha Christie"; 
    "Marcel Proust"; 
    "Jane Austen"; 
    "Fernando Pessoa";
    "Franz Kafka";
    "Clarice Lispector";
    "Fiódor Dostoiévski";
    "Ulisses";
    "Sylvia Plath";
    "Anton Chehkov";
    "Ivan Turguêniev";
    "Machado de Assis"
]

for nome in (retornaIniciadosPorVogal nomes) do
    Console.WriteLine $"{nome} inicia com vogal."

(* 
    Observações:
    F# é associativa à esquerda, então o código abaixo está incorreto: 
    Console.WriteLine retornaIniciadosPorVogal nomes

    Enquanto esse, correto:
    Console.WriteLine (retornaIniciadosPorVogal nomes)
*)