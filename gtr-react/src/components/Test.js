import { useState } from "react";
import { useAuth } from "./Auth/AuthContext";

const Test = () => {

    const { getProducts } = useAuth();

    const [showList, setShowList] = useState(false);
    const [list, setList] = useState({});

    const handleButtonClick = () => {



        setShowList(true);
    };

    return (
        <div>
            <button onClick={handleButtonClick}>Show List</button>
            {showList && (
                <ul>
                    {list.map((item, index) => (
                        <li key={index}>{item}</li>
                    ))}
                </ul>
            )}
        </div>
    );
};

export default Test;
