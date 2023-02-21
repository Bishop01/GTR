import React, { useContext, useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { AxiosInstance, Refresh, InitializeToken } from "./AxiosInstance";

const AuthContext = React.createContext();

export const useAuth = () => {
  return useContext(AuthContext);
};

export const AuthProvider = ({ children }) => {
  const axios = AxiosInstance;
  const [currentUser, setCurrentUser] = useState(JSON.parse(localStorage.getItem("currentUser")))

  const navigate = useNavigate();

  const Refresh = async () => {
    debugger
    try {
      var result = await axios.post("api/Auth/Refresh", { email: currentUser.email, refreshToken: localStorage.getItem("refreshToken") })
      return result

    } catch (error) {
      return error
    }
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
        setCurrentUser(result.data.user)
        localStorage.setItem("refreshToken", result.data.refreshToken);
        localStorage.setItem("accessToken", result.data.accessToken);
        localStorage.setItem("currentUser", JSON.stringify(result.data.user));
      }

      navigate("/manage")
      return

    } catch (error) {
      if (error.response)
        return error.response.status

      return 500
    }

  }

  const getProducts = async () => {
    debugger
    try {
      var result = await axios.post("api/Product/GetProducts", { id: currentUser.id, email: currentUser.email, name: currentUser.name });
      if (result && result.status === 200) {
        return result.data
      }

    }
    catch (error) {
      try {
        result = await Refresh();
        if (result && result.status === 200) {
          localStorage.setItem("accessToken", result.data)

          result = await axios.post("api/Product/GetProducts", { id: currentUser.id, email: currentUser.email, name: currentUser.name }, {
            headers: {
              Authorization: `${localStorage.getItem("accessToken")}`
            }
          });
          if (result && result.status === 200) {
            return result.data
          }
        }
      }
      catch (error) {
        console.log(error)
        return 500;
      }
    }
  }

  const addProduct = async (product) => {

    debugger

    try {
      var result = await axios.post("api/Product/Add", {
        headers: {
          "Content-Type": "application/json"
        },
        data: {
          product
        }
      })
      if (result && result.status === 200)
        return 200
    } catch (error) {
      try {
        result = await Refresh();
        if (result && result.status === 200) {
          localStorage.setItem("accessToken", result.data)

          result = await axios.post("api/Product/Add", {
            headers: {
              Authorization: `${localStorage.getItem("accessToken")}`
            },
            data: {
              product
            }
          });
          if (result && result.status === 200) {
            return result.data
          }
        }
      } catch (error) {
        return 500
      }
    }
  }

  const getCategories = async () => {
    console.log(currentUser)
    try {
      var result = await axios.post("api/Product/GetCategories", { id: currentUser.id, email: currentUser.email, name: currentUser.name });
      if (result && result.status === 200) {
        return result.data
      }

    }
    catch (error) {
      try {
        result = await Refresh();
        if (result && result.status === 200) {
          localStorage.setItem("accessToken", result.data)

          result = await axios.post("api/Product/GetCategories", { id: currentUser.id, email: currentUser.email, name: currentUser.name }, {
            headers: {
              Authorization: `${localStorage.getItem("accessToken")}`
            }
          });
          if (result && result.status === 200) {
            return result.data
          }
        }
      }
      catch (error) {
        console.log(error)
        return 500;
      }
    }
  }

  const value = {
    login,
    currentUser,
    getProducts,
    getCategories,
    addProduct
  };

  return <AuthContext.Provider value={value}>{children}</AuthContext.Provider>;
};
