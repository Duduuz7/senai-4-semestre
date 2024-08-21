import { useState } from "react";
import { DeleteTask, UpdateTask } from "../Buttons/Buttons";
import "./CheckList.css"
import ModalUpdate from "../Modal/ModalUpdate";

export function CheckList({ tasks, onUpdate, onDelete, onChange }) {

    const [showModalUp, setShowModalUp] = useState(false);

    const [currentIndex, setCurrentIndex] = useState(null);

    const handleUpdateClick = (index) => {
        setCurrentIndex(index);
        setShowModalUp(true);
    };

    return (
        <ul className="checklist">
            {tasks.map((task, index) => (

                <li key={index} className={task.toDo ? "task-complete" : "task"}>

                    <div className="container-input-desc">

                        <input
                            type="checkbox"
                            checked={task.toDo}
                            onChange={() => onChange(index)}
                        />

                        <span className={task.toDo ? "description-task" : "description-task-complete"}>{task.description}</span>

                    </div>

                    {task.toDo == false

                        ?

                        <div className="container-button">
                            <UpdateTask onClick={() => handleUpdateClick(index)} />
                            <DeleteTask onClick={() => onDelete(index)} />
                        </div>

                        :

                        <></>

                    }

                    {/* garante que o modal só seja aberto se o index atual (do state currentIndex) for igual ao index da tarefa apertada*/}
                    {showModalUp && currentIndex === index && (
                        <ModalUpdate
                            // passa o index atual para o modalupdate, para ele pegar o index da tarefa que deve mudar a descricao la, passando para o método que vem da home
                            index={currentIndex}
                            // pega o método de update da home
                            onUpdateTask={onUpdate}
                            closeModal={() => setShowModalUp(false)}
                        />
                    )}


                </li>
            )

            )}


        </ul>
    );
}

