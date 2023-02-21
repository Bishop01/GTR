import axios from "axios";

export const AxiosInstance = axios.create({
  baseURL: "https://localhost:44394/",
  responseType: "json",
  headers: {
    Authorization: `${localStorage.getItem("accessToken")}`
  }
});