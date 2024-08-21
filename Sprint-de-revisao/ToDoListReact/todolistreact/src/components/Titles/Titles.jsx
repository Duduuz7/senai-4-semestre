import "./Titles.css"

const DiaSemana = [
  "Domingo",
  "Segunda",
  "Terça",
  "Quarta",
  "Quinta",
  "Sexta",
  "Sábado",
]

const MesAno = [
  "Janeiro",
  "Fevereiro",
  "Março",
  "Abril",
  "Maio",
  "Junho",
  "Julho",
  "Agosto",
  "Setembro",
  "Outubro",
  "Novembro",
  "Dezembro",
]


export function MainTitle({dayText, day, month}) {

  const data = new Date();

  const dia = data.getDay();
  const diaNumero = data.getDate();
  const mes = data.getMonth();

  return (
    <h1 className="main-title">{`${DiaSemana[dia]}, `} <span className="span-day">{diaNumero}</span> de {MesAno[mes]}</h1>
  );
}


export function ModalTitle() {
  return (
    <h1 className="modal-text">Descreva sua tarefa</h1>
  )
}
