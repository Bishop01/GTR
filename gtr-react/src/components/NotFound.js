import { Link } from "react-router-dom";

const NotFound = () => {
    return (
        <div className="flex flex-col items-center justify-center h-screen">
            <h1 className="text-4xl font-bold mb-4">404 Not Found</h1>
            <p className="text-lg text-gray-600">
                Sorry, we couldn't find the page you're looking for.
            </p>
            <Link
                to="/"
                className="mt-8 bg-blue-500 text-white py-2 px-4 rounded hover:bg-blue-600 transition duration-150 ease-in-out"
            >
                Go back home
            </Link>
        </div>
    );
};

export default NotFound;
