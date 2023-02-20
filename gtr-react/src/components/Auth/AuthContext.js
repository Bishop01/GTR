import React, { useContext, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { AxiosInstance } from "./AxiosInstance";

const AuthContext = React.createContext();

export const useAuth = () => {
  return useContext(AuthContext);
};

export const AuthProvider = ({ children }) => {
  const axios = AxiosInstance;

  const [currentUser, setCurrentUser] = useState(null);
  const [accessToken, setAccessToken] = useState("");
  const [refreshToken, setRefreshToken] = useState("");

  const navigate = useNavigate();

  const storeCred = () => {
    setCurrentUser(localStorage.getItem("currentUser"));
    setAccessToken(localStorage.getItem("accessToken"));
    setRefreshToken(localStorage.getItem("refreshToken"));
  }

  const login = async (email, password) => {
    debugger
    try {
      var result = await axios.post('/api/Auth/Login', { email: email, password: password },
        {
          headers: {
            "Content-type": "application/json",
          },
        })

      if (result && result.status === 200) {
        setCurrentUser(result.data.user);
        setAccessToken(result.data.accessToken);
        setRefreshToken(result.data.refreshToken);

        localStorage.setItem("refreshToken", result.data.refreshToken);
        localStorage.setItem("accessToken", result.data.accessToken);
        localStorage.setItem("currentUser", JSON.stringify(result.data.user));
      }

      navigate("/manage")

    } catch (error) {
      return error.response.status
    }

  }

  const value = {
    login,
  };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
