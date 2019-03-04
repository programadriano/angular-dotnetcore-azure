export class Destaque {
    constructor(
       public _id: String,
       public  editoria: String,
       public  title: String,
       public  link_banner: String,
       public  description: String,
       public  url_image_banner: String,
       public  dateCreated: Date,
       public  __v: Number,
       public  dateUpdated: Date
    ){}
}