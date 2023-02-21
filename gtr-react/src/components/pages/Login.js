import { useState } from "react";
import { useAuth } from "../../api/Auth/AuthContext";

const Login = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [error, setError] = useState("");

    const { login } = useAuth();

    const handleLogin = async (e) => {
        e.preventDefault();
        setError("");

        const code = await login(email, password);
        if (code === 404) {
            setError("Incorrect email or password!")
        }
        else {
            setError("Internal Server Error! Try again later.")
        }
    };

    const onChangeEmail = (e) => {
        setEmail(e.target.value)
        setError("");
    }

    const onChangePass = e => {
        setPassword(e.target.value)
        setError("");
    }

    return (
        <div className="flex justify-center items-center h-screen w-full">
            <form className="bg-white p-8 rounded shadow-md w-[25%]" onSubmit={handleLogin}>
                <h2 className="text-xl font-bold mb-4">Login</h2>
                <div className="mb-4">
                    <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="email">Email</label>
                    <input
                        className="border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                        id="email"
                        type="email"
                        value={email}
                        onChange={e => onChangeEmail(e)}
                        placeholder="Enter your email"
                        required
                    />
                </div>
                <div className="mb-4">
                    <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="password">Password</label>
                    <input
                        className="border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                        id="password"
                        type="password"
                        value={password}
                        onChange={(e) => onChangePass(e)}
                        placeholder="Enter your password"
                        required
                    />
                </div>
                <div className="mb-4 text-xs text-red-500">
                    {error}
                </div>
                <button className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded" type="submit">Login</button>
            </form>
        </div>
    );
};

export default Login