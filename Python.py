import pymongo

myclient = pymongo.MongoClient("mongodb://localhost:27017/")
mydb = myclient["BookstoreDb"]
mycol = mydb["Books"]


def Insert(data):
    mycol.insert_one(data)



Insert(
    {
        "BookName":"DePython",
        "Price":54.93,
        "Category":"Computers",
        "Author":"abc"
    }
)
