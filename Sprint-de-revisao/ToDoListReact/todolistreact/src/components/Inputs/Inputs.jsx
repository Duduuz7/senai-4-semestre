
import "./Inputs.css"

import searchIcon from "../../assets/search-icon.svg"

export function MainInput({onChangeSearch, value}) {
    return (
        <div className="container-input">
            <img style={{ marginLeft: "10px" }} src={searchIcon} />
            <input onChange={(x) => onChangeSearch(x.target.value)} value={value} placeholder="Procurar tarefa" className="main-input" />
        </div>
    );
}

// export function InputCheck() {
//     return (
        
//     );
// }


