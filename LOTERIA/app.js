var LoteriaClass = require('./Loteria');
var JogoClass = require('./Jogo');

var minhaLoteria = new LoteriaClass([45,13,1,18,33,69], 100000);

// minhaLoteria.showSorteio();
minhaLoteria.addJogo(new JogoClass([1,15,17,33,35,18]));
minhaLoteria.addJogo(new JogoClass([3,5,59,33,17,17]));
minhaLoteria.addJogo(new JogoClass([45,13,1,18,33,35]));

minhaLoteria.showJogos();
console.log("Qnt de jogares que acertaram exatamente 4: ", minhaLoteria.calculaGanhador(4));
console.log("Numeros mais jogados: ", minhaLoteria.maisJogado());
console.log("Numeros nao jogados: ", minhaLoteria.naoJogado());
minhaLoteria.resultado();
