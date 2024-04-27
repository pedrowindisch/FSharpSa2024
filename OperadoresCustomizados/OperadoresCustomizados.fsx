(*
    No F#, operadores são apenas funções:
        (>>), por exemplo, é uma função que aceita 
        duas funções como parâmetro, onde a assinatura da 1a. seria
                        'a -> 'b
        enquanto da segunda,
                        'b -> 'c
        e retorna uma terceira função com a assinatura
                        'a -> 'c

    Assim, também podemos definir nossos próprios operadores.

    Leia mais:
        - Operator overloading - creating new operators
          https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/operator-overloading#creating-new-operators
*)


(* ADICIONA NO INICIO *)
(*
    Um dos operadores nativos do F# é o @, que concatena duas listas juntas.
        [1; 2; 3] @ [4]             -> [1; 2; 3; 4]
        [4] @ [1; 2; 3]             -> [4; 1; 2; 3]

    Tente implementar o operador @<, que concatena a segunda lista no início da primeira lista:
        [1; 2; 3] @< [4]             -> [4; 1; 2; 3]

    O início do código já se encontra abaixo.
*)

let (@<) x y =
    [] // Remova/altere essa linha

printfn "%A" (["academica"; "2024"] @< ["semana"]) // Deve imprimir ["semana"; "academica"; "2024"]