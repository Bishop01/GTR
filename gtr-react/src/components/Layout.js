import { useEffect, useState } from "react";
import { NavLink, Outlet, useNavigate } from "react-router-dom";
import { useAuth } from "./../api/Auth/AuthContext";

const Layout = () => {

    const { refreshToken, storeCred } = useAuth();

    const navigate = useNavigate();

    const [expand, setExpand] = useState(false);

    useEffect(() => {
        if (localStorage.getItem("refreshToken") === "")
            navigate("/login")
    }, [refreshToken])

    return (
        <div className="flex flex-col h-screen">
            {/* Navbar */}
            <nav className="bg-blue-500 h-16 flex items-center justify-between px-4">
                {/* Logo */}
                <div>
                    <NavLink to="/" className="text-white font-bold">
                        My App
                    </NavLink>
                </div>

                {/* Navigation links */}
                <div className="flex items-center">
                    <div className="ml-4 flex items-center">
                        {/* Profile dropdown */}
                        <div className="relative">
                            <button
                                onClick={e => { setExpand(!expand) }}
                                className="flex text-sm border-2 border-transparent rounded-full focus:outline-none focus:border-white transition duration-150 ease-in-out">
                                <img
                                    className="h-8 w-8 rounded-full"
                                    src="https://via.placeholder.com/150"
                                    alt="Profile"
                                />
                            </button>
                            {expand &&
                                <div className="origin-top-right absolute right-0 mt-2 w-48 rounded-md shadow-lg z-10">
                                    <div className="py-1 rounded-md bg-white shadow-xs">
                                        <NavLink
                                            to="/profile"
                                            className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 hover:text-gray-900"
                                            activeClassName="bg-blue-200 text-blue-700"
                                        >
                                            Profile
                                        </NavLink>
                                        <NavLink
                                            to="/signout"
                                            className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 hover:text-gray-900"
                                            activeClassName="bg-blue-200 text-blue-700"
                                        >
                                            Sign out
                                        </NavLink>
                                    </div>
                                </div>
                            }
                        </div>
                    </div>
                </div>
            </nav>

            {/* Main content */}
            <div className="flex-1">
                <Outlet />
            </div>
        </div>
    );
};

export default Layout;
