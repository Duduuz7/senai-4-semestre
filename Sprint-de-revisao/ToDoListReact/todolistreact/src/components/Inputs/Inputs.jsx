
import "./Inputs.css"

import searchIcon from "../../assets/search-icon.svg"

export function MainInput() {
    return (
        <div className="container-input">
            <img style={{marginLeft: "10px"}} src={searchIcon} />
            <input placeholder="Procurar tarefa" className="main-input" />
        </div>
    );
}

export function InputCheck() {
    return (
        <input type="checkbox" className="check-input" />
    );
}

