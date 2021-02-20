using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin_API.Models
{
    public class CoinBank
    {

        public CoinBank()
        {
            data = new List<CoinClientModel>();
            Coins = new List<Coin>();
            Images = new Dictionary<int, string>();
            LoadImages();
        }
        public List<CoinClientModel> data;

        public List<Coin> Coins;

        public Dictionary<int,string> Images;

        public void LoadImages()
        {
            Images.Add(1,"https://pbs.twimg.com/profile_images/421692600446619648/dWAbC2wg_400x400.jpeg");
            Images.Add(2,"https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Ethereum-icon-purple.svg/1200px-Ethereum-icon-purple.svg.png");
            Images.Add(3,"https://s2.coinmarketcap.com/static/img/coins/200x200/1839.png");
            Images.Add(4,"https://assets.coingecko.com/coins/images/12171/large/aJGBjJFU_400x400.jpg?1597804776");
            Images.Add(5,"https://icons-for-free.com/iconfiles/png/512/cardano+icon-1320162855683510157.png");
            Images.Add(6,"https://s2.coinmarketcap.com/static/img/coins/200x200/52.png");
            Images.Add(7,"https://seeklogo.com/images/T/tether-usdt-logo-FA55C7F397-seeklogo.com.png");
            Images.Add(8,"https://blockogy.com/wp-content/uploads/2018/01/litecoin.png");
            Images.Add(9,"https://assets.coingecko.com/coins/images/780/large/bitcoin-cash-circle.png?1594689492");
            Images.Add(10,"https://assets.coingecko.com/coins/images/877/large/chainlink-new-logo.png?1547034700");
            Images.Add(11,"https://assets.coingecko.com/coins/images/100/large/Stellar_symbol_black_RGB.png?1552356157");
            Images.Add(12,"https://i2.wp.com/fastandclean.org/wp-content/uploads/2021/01/UniSwap-logo.png?resize=283%2C283&ssl=1");
            Images.Add(13,"https://s2.coinmarketcap.com/static/img/coins/200x200/74.png");
            Images.Add(14,"https://s2.coinmarketcap.com/static/img/coins/200x200/3717.png");
            Images.Add(15,"https://s2.coinmarketcap.com/static/img/coins/200x200/7278.png");
            Images.Add(16,"https://cdn4.iconfinder.com/data/icons/crypto-currency-and-coin-2/256/eos_eoscoin_coin-512.png");
            Images.Add(17,"https://thumbs.dreamstime.com/b/crypto-currency-golden-coin-black-lackered-nem-symbol-obverse-isolated-black-background-vector-illustration-use-100676239.jpg");
            Images.Add(18,"https://s2.coinmarketcap.com/static/img/coins/200x200/328.png");
            Images.Add(19,"https://www.pngitem.com/pimgs/m/259-2598854_bitcoin-sv-hd-png-download.png");
            Images.Add(20,"https://assets.coingecko.com/coins/images/1481/large/cosmos_hub.png?1555657960");
        }
    }
}