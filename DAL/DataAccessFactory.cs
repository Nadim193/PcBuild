﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DataAccessFactory
    {

        public static IRepo<Seller , string, bool> SellerData()
        {
            return new SellerRepo();
        }
        public static IRepo<Product , int , bool> ProductData()
        {
            return new ProductRepo();
        }

        public static IRepo<Order, int, bool> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepoUsers<User, int, string, decimal, bool> ManageUserData()
        {
            return new UserRepo();
        }
        public static IRepoUsers<Product, int, string, int, Product> ManageProductData()
        {
            return new ManageProductRepo();
        }
        public static IRepoOrder<Order, int, Order> ManageOrderData()
        {
            return new ManageOrderRepo();
        }
        public static IRepo<Review, int, bool> ManageReviewData()
        {
            return new ManageReviewRepo();
        }
        public static IRepoCart<Cart, int, int, Cart> ManageCartData()
        {
            return new ManageCartRepo();
        }
        public static IRepoCart<User_Order, int, int, bool> ManageUserOrderData()
        {
            return new ManageUserOrderRepo();
        }
        public static IRepoCart<ProductOrder, int, int, bool> ManageProductOrderData()
        {
            return new ManageProductOrderRepo();
        }
        public static IRepo<FeedBack, int, bool> ManageFeedBackData()
        {
            return new ManageFeedBackRepo();
        }
        public static IRepo<Token, string, bool> TokenData()
        {
            return new TokenRepo();
        }
        public static IAuth<bool> AuthData()
        {
            return new SellerRepo();
        }
        public static IAuth<bool> UserAuthData()
        {
            return new UserRepo();
        }
        public static IChange ChangePassData()
        {
            return new SellerRepo();
        }
    }
}