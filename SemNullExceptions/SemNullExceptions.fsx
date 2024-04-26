(*
    Com as uniões discriminadas, podemos forçar o desenvolvedor a 
    tratar todos os casos e comportamentos possíveis de um código.

    Um caso em particular que é muito comum passar batido: valores nulos.

    Em F#, não existe o conceito de nulo*. Mas então, como representamos a
    ausência de um valor? 
*)

type PossoSerNulo<'Tipo> = // Tipo genérico 
    | NaoSouNulo of 'Tipo
    | SouNulo

let retornaPrimeiraAvaliacaoMenorQueSete avaliacoes = 
    try
        let avaliacao = List.find (fun (_, nota) -> nota < 7.0) avaliacoes
        NaoSouNulo(avaliacao)
    with
        | _ -> SouNulo

let jeanLucGodard = [
    ("Pierrot Le Fou", 8.9); 
    ("Vivre sa vie", 7.1); 
    ("Il disprezzo", 9.6); 
    ("Masculin Feminin", 7.8)
]

let filmeRuim = retornaPrimeiraAvaliacaoMenorQueSete jeanLucGodard
let nome, nota = filmeRuim // Por que eu não consigo fazer isso?