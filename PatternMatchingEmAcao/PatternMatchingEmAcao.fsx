(* O pattern matching, de início, parece como um switch normal, mas é muito mais poderoso e capaz. *)
(* VERIFICAÇÃO EXAUSTIVA DE CASOS *)
type ParOrdenado = {
    X: int;
    Y: int;
}

let verificaInterseccao par =
    match par with // Por que estamos com um aviso aqui?
    | { X = 0; Y = _ } -> "Intersecção em Y"
    | { X = _; Y = 0 } -> "Intersecção em X"
 
printfn "%s" (verificaInterseccao { X = 5; Y = 0 })



(* ASSOCIACAO DE VALOR DENTRO DA CONDICIONAL *)
open System

let discNota = [
    ("Lógica para computação", 7.5);
    ("Banco de dados", 9.5);
    ("Introdução à programação", 8.5);
    ("Outra disciplina", 5.8);
    ("Diversidade e sociedade", 7.4);
]

let verificaSituacao discNota =
    match discNota with
    | (disciplina, nota) when nota < 6.0 -> sprintf "Aluno reprovou na disciplina %s (%.2f)" disciplina nota
    | (disciplina, nota) when nota < 8.0 -> sprintf "Aluno poderia ter ido melhor na disciplina %s (%.2f)" disciplina nota
    | (disciplina, nota) -> sprintf "Aluno foi bem na disciplina %s (%.2f)" disciplina nota

discNota 
    |> List.map verificaSituacao
    |> List.map Console.WriteLine
