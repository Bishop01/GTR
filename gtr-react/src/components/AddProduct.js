import React from "react";

const AddProduct = ({ selectedCategory, onUpdateProduct, add }) => {
    return (
        <div className="absolute w-full h-[50%] bottom-0 bg-gray-100 flex flex-col justify-center items-center border-t">
            <h1 className="text-3xl font-bold mb-6">Add Product</h1>
            <div className="w-full max-w-5xl">
                <div className="flex flex-wrap justify-between mb-6">
                    <div className="w-[25%] p-2">
                        <label htmlFor="category" className="font-bold block mb-2">
                            Category:
                        </label>
                        <input
                            value={selectedCategory.name}
                            readOnly
                            type="text"
                            id="category"
                            name="category"
                            className="w-full bg-gray-200 px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                    <div className="w-[25%] p-2">
                        <label htmlFor="name" className="font-bold block mb-2">
                            Name:
                        </label>
                        <input
                            onChange={e => { onUpdateProduct(e) }}
                            type="text"
                            id="name"
                            name="name"
                            className="w-full px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                    <div className="w-[25%] p-2">
                        <label htmlFor="description" className="font-bold block mb-2">
                            Description:
                        </label>
                        <input
                            onChange={e => { onUpdateProduct(e) }}
                            type="text"
                            id="description"
                            name="description"
                            className="w-full px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                    <div className="w-[25%] p-2">
                        <label htmlFor="size" className="font-bold block mb-2">
                            Size:
                        </label>
                        <input
                            onChange={e => { onUpdateProduct(e) }}
                            type="text"
                            id="size"
                            name="size"
                            className="w-full px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                </div>
                <div className="flex flex-wrap justify-between">
                    <div className="w-[25%] p-2">
                        <label htmlFor="color" className="font-bold block mb-2">
                            Color:
                        </label>
                        <input
                            onChange={e => { onUpdateProduct(e) }}
                            type="text"
                            id="color"
                            name="color"
                            className="w-full px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                    <div className="w-[25%] p-2">
                        <label htmlFor="model" className="font-bold block mb-2">
                            Model:
                        </label>
                        <input
                            onChange={e => { onUpdateProduct(e) }}
                            type="text"
                            id="model"
                            name="model"
                            className="w-full px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                    <div className="w-[25%] p-2">
                        <label htmlFor="variant" className="font-bold block mb-2">
                            Variant:
                        </label>
                        <input
                            onChange={e => { onUpdateProduct(e) }}
                            type="text"
                            id="variant"
                            name="variant"
                            className="w-full px-3 py-2 border border-gray-400 rounded-md focus:outline-none focus:ring-2 focus:ring-blue-500"
                        />
                    </div>
                </div>
                <div className="flex justify-end mt-6">
                    <button
                        onClick={e => add(e)}
                        type="button"
                        className="py-2 px-4 bg-blue-500 text-white rounded-md hover:bg-blue-600 focus:outline-none focus:ring-2 focus:ring-blue-500 focus:ring-offset-2 w-full sm:w-auto"
                    >
                        Add
                    </button>
                </div>
            </div>
        </div>
    );
}

export default AddProduct