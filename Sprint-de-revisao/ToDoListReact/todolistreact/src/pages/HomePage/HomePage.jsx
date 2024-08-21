import { useState } from "react";
import { NewTaskButton } from "../../components/Buttons/Buttons";
import Container from "../../components/Container/Container";
import { MainInput } from "../../components/Inputs/Inputs";
import MainContent from "../../components/MainContent/MainContent";
import { MainTitle } from "../../components/Titles/Titles";
import ModalCheck from "../../components/Modal/Modal";
import { CheckList } from "../../components/CheckList/CheckList";


function HomePage() {

  const [showModal, setShowModal] = useState(false);

  const [tasks, setTasks] = useState([]);

  const handleAddTask = (description) => {
    setTasks([...tasks, { description, toDo: false }]);
  };

  const handleCheckTask = (index) => {
    const newCheckTask = [...tasks]; //Cria um novo array com os itens do array normal para atualizar
    newCheckTask[index].toDo = !newCheckTask[index].toDo; //seta o toDo, que seria o checked do input como true se estiver false e vice e versa
    setTasks(newCheckTask);
  };


  const handleDeleteTask = (index) => {
    setTasks(tasks.filter((_, i) => i !== index)); //no lugar do "_" seria o item do array, mas como nesse caso nao vou utilizo-lo, uso o "_" para ignorar esse parâmetro. Utilizo apenas o índice (i) para comparar com o índice do item a ser excluido
  };


  return (
    <MainContent>

      <Container>

        <MainTitle />

        <MainInput />

        <CheckList
          tasks={tasks}
          onChange={handleCheckTask}
          onDelete={handleDeleteTask}
        />

      </Container>

      <NewTaskButton onClick={() => setShowModal(true)} />

      {showModal ? <ModalCheck onAddTask={handleAddTask} closeModal={() => setShowModal(false)} /> : <></>}

    </MainContent>


  );
}

export default HomePage;
