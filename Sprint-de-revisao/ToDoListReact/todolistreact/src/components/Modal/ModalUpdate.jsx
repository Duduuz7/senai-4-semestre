import React, { useState } from 'react';
import './Modal.css';
import { ModalTitle } from '../Titles/Titles';
import { ConfirmTask } from '../Buttons/Buttons';

const ModalUpdate = ({closeModal, onUpdateTask, index }) => {

  const [taskDescription, setTaskDescription] = useState('');

  const handleUpdateTask = () => {
    if (index !== null && taskDescription !== '') {
      onUpdateTask(index, taskDescription);
      setTaskDescription('');
      closeModal();
    }else {
      alert('Digite uma descrição para sua tarefa !!!');
    }
  }

  return (
    <div className="modal">

      <div className="modal-content">

        <ModalTitle/>

        <input 
          className="modal-input"
          type="text"
          value={taskDescription} 
          onChange={(e) => setTaskDescription(e.target.value)} 
          placeholder="Tarefa..." 
        />

        <ConfirmTask text={"Atualizar tarefa"} onClick={handleUpdateTask}/>

      </div>

    </div>
  );
};

export default ModalUpdate;