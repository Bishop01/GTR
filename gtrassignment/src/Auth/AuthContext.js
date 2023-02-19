import React, { useContext, useEffect, useState } from "react";
import { AxiosInstance } from "./AxiosInstance";

const AuthContext = React.createContext();

export const useAuth = () => {
    return useContext(AuthContext);
};

export const AuthProvider = ({ children }) => {

    const axios = AxiosInstance;
    const [currentUser, setCurrentUser] = useState("");
    const [accessToken, setAccessToken] = useState("");
    const [refreshToken, setRefreshToken] = useState("");

    const login = async (email, password) => {
        const result = await axios.get("api/auth/login");

        if (result && result.Status === 200) {
            setAccessToken(result.AccessToken)
            setCurrentUser(result.User)
        }
    }

    const value = {

    };

    return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
