import axios from "axios";

export const AxiosInstance = axios.create({
  baseURL: "https://localhost:44394/",
});

export const InitializeToken = () => {
  //const auth = `Bearer ${token}`;
  AxiosInstance.defaults.headers.common = {
    Authorization: `${localStorage.getItem("accessToken")}`,
    "Content-type": "application/json",
  };
};
