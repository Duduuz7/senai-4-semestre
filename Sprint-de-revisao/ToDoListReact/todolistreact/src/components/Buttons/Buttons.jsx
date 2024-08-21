import "./Buttons.css"

import PencilIcon from "../../assets/pencil-icon.svg"

import DeleteIcon from "../../assets/delete-icon.svg"

export function NewTaskButton({ onClick }) {
    return (
        <button onClick={onClick} className="task-button">Nova Tarefa</button>
    );
}

export function ConfirmTask({ onClick, text }) {
    return (
        <button onClick={onClick} className="confirm-button">{text}</button>
    )
}
    
export function DeleteTask({ onClick }) {
    return (
        <button onClick={onClick} className="delete-button"> <img color="white" src={DeleteIcon} /> </button >
    )
}

export function UpdateTask({ onClick }) {
    return (
        <button onClick={onClick} className="update-button"> <img src={PencilIcon} /> </button >
    )
}