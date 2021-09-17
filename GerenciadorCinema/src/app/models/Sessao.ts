import { Filme } from "./Filme";
import { Sala } from "./Sala";

export class Sessao {
    id: number;
    data: Date;
    horarioInicial: Date;
    horarioFInal: Date;
    valorIngresso: number;
    tipoAnimacao: string;
    tipoAudio: string;
    filme: Filme;
    sala: Sala;
}
