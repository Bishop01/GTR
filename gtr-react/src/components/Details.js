import { useEffect, useState } from "react";

const Details = ({ categories, selectedCategory, selectedProduct, setSelectedCategory, setSelectedProduct }) => {

    return (
        <div className="flex">
            <div className="w-1/4 p-4 bg-gray-100">
                <h1 className="text-2xl font-bold mb-4">Categories</h1>
                <ul>
                    {categories.map((category) => (
                        <li
                            key={category.id}
                            onClick={() => setSelectedCategory(category)}
                            className={`py-2 px-4 cursor-pointer ${selectedCategory.id === category.id ? "bg-gray-300" : ""
                                }`}
                        >
                            {category.name}
                        </li>
                    ))}
                </ul>
            </div>
            <div className="w-1/4 p-4 bg-gray-200">
                <h1 className="text-2xl font-bold mb-4">{selectedCategory.name}</h1>
                <ul>
                    {selectedCategory.products.map((product) => (
                        <li
                            key={product.id}
                            onClick={() => setSelectedProduct(product)}
                            className={`py-2 px-4 cursor-pointer ${selectedProduct.id === product.id ? "bg-gray-300" : ""
                                }`}
                        >
                            {product.name}
                        </li>
                    ))}
                </ul>
            </div>
            <div className="w-1/2 p-4 bg-gray-300">
                <h1 className="text-2xl font-bold mb-4">{selectedProduct.name}</h1>
                <p className="mb-4">{selectedProduct.description}</p>
                <p className="text-xl font-bold">${selectedProduct.price}</p>
            </div>
        </div>
    )
}

export default Details