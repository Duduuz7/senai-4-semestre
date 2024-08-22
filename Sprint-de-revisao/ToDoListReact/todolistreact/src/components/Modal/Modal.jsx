import React, { useState } from 'react';
import './Modal.css';
import { ModalTitle } from '../Titles/Titles';
import { ConfirmTask } from '../Buttons/Buttons';

const ModalCheck = ({ onAddTask, closeModal}) => {
  const [taskDescription, setTaskDescription] = useState('');

  const handleAddTask = () => {

    if (taskDescription !== null && taskDescription !== '') {
      onAddTask(taskDescription);
      setTaskDescription('');
      closeModal();
    }
    else {
      	alert('Por favor digite uma descrição para a sua tarefa !!!');
    }

  }

  return (
    <div className="modal">

      <div className="modal-content">

        <ModalTitle />

        <input
          className="modal-input"
          type="text"
          value={taskDescription}
          onChange={(e) => setTaskDescription(e.target.value)}
          placeholder="Tarefa..."
        />

        <ConfirmTask text={"Confirmar tarefa"} onClick={handleAddTask} />

      </div>

    </div>
  );
};

export default ModalCheck;