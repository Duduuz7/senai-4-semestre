import { DeleteTask, UpdateTask } from "../Buttons/Buttons";
import "./CheckList.css"



export function CheckList({ tasks, onUpdate, onDelete, onChange }) {
    return (
        <ul className="checklist">
            {tasks.map(
                (
                    task,
                    index
                ) => (
                    <li key={index} className="task">

                        <div className="container-input-desc">

                            <input
                                // className="check-input"
                                type="checkbox"
                                checked={task.toDo}
                                onChange={() => onChange(index)}
                            />

                            <span className="description-task">{task.description}</span>

                        </div>

                        <div className="container-button">
                            <UpdateTask onClick={() => ""}/>
                            <DeleteTask onClick={() => onDelete(index)}/>
                        </div>

                    </li>
                )

            )}


        </ul>
    );
}

