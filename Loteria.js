class Loteria {
  constructor(sorteio, valor){
    this.sorteio = sorteio;
    this.jogos = [];
    this.valor = valor;
    this.numerosJogado = [];
  }
  showSorteio() {
    this.sorteio.forEach((numero)=>{
      console.log(numero);
    });
  }
  addJogo(jogo) {
    this.jogos.push(jogo);
    jogo.getJogo().forEach((numero)=>{
      let bJaFoiJogado = false;
      this.numerosJogado.forEach((numeroJogado, index)=>{
        if(numeroJogado.numero == numero) {
          bJaFoiJogado = true;
          this.numerosJogado[index].vezesJogado = this.numerosJogado[index].vezesJogado+1;
        }
      });

      if(!bJaFoiJogado){
        this.numerosJogado.push({numero: numero, vezesJogado:1});
      }
    });
  }
  showJogos() {
    this.jogos.forEach((jogo, index)=>{
      console.log("["+index+"] -> ", jogo.getJogo());
    });
  }

  /* Parte do desafio */
  calculaGanhador(qtdAcertos){
    let contGanhador = 0;

    this.jogos.forEach((jogo)=>{
      let contAcerto = 0;

      jogo.getJogo().forEach((numero)=>{
        this.sorteio.forEach((numeroSorteado)=>{
          contAcerto = (numero==numeroSorteado)?(contAcerto+1):contAcerto;
        });
      });

      contGanhador = (contAcerto>=qtdAcertos)?(contGanhador+1):contGanhador;
    });

    return contGanhador;
  }
  maisJogado(){
    let theIndex = 0;
    this.numerosJogado.forEach((obj, index)=>{
      if(obj.vezesJogado > this.numerosJogado[theIndex].vezesJogado) {
        theIndex = index;
      }
    });
    return this.numerosJogado[theIndex].numero;
  }
  naoJogado(){
    let numerosNaoJogados = [];
    this.sorteio.forEach((numeroSorteado)=>{
      let bFoiJogado=false;
      this.numerosJogado.forEach((obj, index)=>{
        if(obj.numero == numeroSorteado) {
          bFoiJogado=true;
        }
      });
      if(!bFoiJogado) {
        numerosNaoJogados.push(numeroSorteado);
      }
    });
    return numerosNaoJogados;
  }
}

module.exports = Loteria;
