import telebot
import random
import emoji

bot = telebot.TeleBot("TOKEN")

candys = 117

@bot.message_handler(func=lambda message: True)
def echo_all(message):
  
   global candys
   
   x = int(message.text)
  
   if x > 0 and x < 29 :
    candys -= x
    bot.send_message(message.chat.id, f'Осталось {candys} конфет')
          
   else:
    
    bot.send_message(message.chat.id, 'Не верное число, пропускаете ход')

    bot.send_message(message.chat.id,emoji.emojize(':confused_face:'))
    #break #почему не хочет так работать (с "break") ,поэтому выше написал "пропускаете ход"
   if candys == 0 or candys < 0:
        bot.send_message(message.chat.id, 'Все, вы выиграли, начните сначала')
        bot.send_message(message.chat.id,emoji.emojize(':thumbs_up:'))
        #break # здесь тоже надо остановить, но неполучается :-((
   x = random.randint(1, 28)
   candys -= x
   if  candys == 0 or candys < 0:
        bot.send_message(message.chat.id, 'Все, бот выиграл, начните сначала')
        bot.send_message(message.chat.id,emoji.emojize(':crying_face:'))                
   else:
    bot.send_message(message.chat.id, f'Бот взял {x}, осталось {candys} конфет')
   bot.send_message(message.chat.id, 'Возьмите не больше 28 конфет')



bot.infinity_polling()