import { useState, useEffect } from "react";
import AddProduct from "../AddProduct";
import Details from "../Details";
import { useNavigate } from "react-router-dom";
import { useAuth } from "./../../api/Auth/AuthContext";

const Manage = () => {

    const [categories, setCategories] = useState()
    const [loading, setLoading] = useState(true)

    const [selectedCategory, setSelectedCategory] = useState();
    const [selectedProduct, setSelectedProduct] = useState();

    const [product, setProduct] = useState({})

    const { getProducts, getCategories, addProduct, currentUser } = useAuth()
    const navigate = useNavigate()

    const load = async () => {
        var result = await getCategories();

        if (result === 401 || result === 500 || localStorage.getItem("accessToken") === "") {
            navigate("/login")
        }
        debugger
        console.log(result)
        setCategories(result)
    }

    const onUpdateProduct = (e) => {
        setProduct({
            ...product,
            [e.target.name]: e.target.value,
            categoryId: selectedCategory.id,
            userId: currentUser.id,
            code: 123,
            productBarcode: 1234
        })
    }

    const add = async () => {
        addProduct(product)
    }

    const onChangeCategory = (e) => {
        console.log("asdsa")
        setSelectedCategory(e);
        setSelectedProduct(e.products[0]);
    }
    const onChangeProduct = (e) => {
        setSelectedProduct(e);
    }

    useEffect(() => {
        load()
    }, [])

    useEffect(() => {
        if (selectedCategory && selectedProduct) {
            setLoading(false)
            return
        }

        if (categories) {
            setSelectedCategory(categories[0])
            setSelectedProduct(categories[0].products[0])
        }
    }, [categories, selectedCategory, selectedProduct])

    return (
        <div className="flex flex-col">
            {!loading &&
                <>
                    <Details categories={categories} selectedCategory={selectedCategory} selectedProduct={selectedProduct} setSelectedCategory={onChangeCategory} setSelectedProduct={onChangeProduct} />
                    <AddProduct add={add} onUpdateProduct={onUpdateProduct} selectedCategory={selectedCategory} selectedProduct={selectedProduct} />
                </>}
        </div>
    );
}

export default Manage