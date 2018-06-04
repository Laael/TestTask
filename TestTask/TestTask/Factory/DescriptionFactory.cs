using System.Collections.Generic;
using TestTask.Model;

namespace TestTask.Factory
{
    public static class DescriptionFactory
    {

        public static List<Description> GetDescription()
        {
            var versions = App.Repository.GetItems();
            var descriptions = new List<Description>();
            foreach (var item in versions)
            {
                switch ((item).ID)
                {
                    case 1:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Cupcake» — версия мобильной операционной системы Android, разработанная компанией Google, основной релиз платформы, предназначенный для мобильных телефонов на базе Android начиная с мая 2009 года, который больше не поддерживается.",
                                version = item
                            });
                            break;
                        }
                    case 2:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Donut» — версия мобильной операционной системы Android с открытым исходным кодом, разработанная Google, которая больше не поддерживается. Среди более заметных особенностей, появившихся в этом обновлении, добавлена поддержка смартфонов CDMA, дополнительные размеры экрана, индикатор использования батареи и механизм преобразования текста в речь",
                                version = item
                            });
                            break;
                        }
                    case 3:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Eclair» — версия мобильной операционной системы Android, разработанной Google, для более не поддерживаемых версий от 2.0 до 2.1. Опубликованный 26 октября 2009 года, Android 2.1 основывается на значительных изменениях в Android 1.6 «Donut»",
                                version = item
                            });
                            break;
                        }
                    case 4:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Froyo» — версия мобильной операционной системы Android, разработанной Google, с версиями от 2.2 до 2.2.3. Эти версии больше не поддерживаются. Он был открыт 20 мая 2010 года во время конференции Google I/O 2010. Одним из наиболее заметных изменений в выпуске Froyo стало использование USB - модемов и функций Wi - Fi - хот - спота. Другие изменения включают поддержку службы Android Cloud to Device Messaging(C2DM), включение push - уведомлений, усовершенствование дополнительной скорости приложения, реализованное посредством JIT - компиляции и отображаемое в приложениях как верхние экранные баннеры.",
                                version = item
                            });
                            break;
                        }
                    case 5:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Gingerbread» — версия мобильной операционной системы Android, разработанное Google и выпущенное в декабре 2010 года для версий, которые больше не поддерживаются. В выпуске Gingerbread была представлена поддержка для ближнепольной связи(NFC),  используемая в мобильных платёжных решениях, и протокол инициации сеанса(SIP), используемый в VoIP - телефонии.",
                                version = item
                            });
                            break;
                        }
                    case 6:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Honeycomb» — это кодовое имя платформы Android, предназначенное для устройств с большим размером экрана, в частности, планшетов. Он больше не поддерживается (более новые версии).",
                                version = item
                            });
                            break;
                        }
                    case 7:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android «Ice Cream Sandwich» — версия мобильной операционной системы Android, разработанная Google. Опубликованный 19 октября 2011 года, Android 4.0 основывается на значительных изменениях, сделанных только для Android-планшета Android Honeycomb, в целях создания единой платформы для смартфонов и планшетов.",
                                version = item
                            });
                            break;
                        }
                    case 8:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android Jelly Bean — версия мобильной операционной системы Android, разработанная Google. Представлено публике 27 июня 2012 года. Четвертая версия ОС Android.",
                                version = item
                            });
                            break;
                        }
                    case 9:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Представлена публике 3 сентября 2013 года и выпущена в виде бета-версии для некоторых моделей серии Google Nexus под названием Android K. Изначально релиз назывался «Key Lime Pie» (лаймовый пирог), но директор глобального сотрудничества Android Джон Лагерлинг и его команда отбросили это кодовое имя, решив, что «лишь некоторые знают вкус лаймового пирога»",
                                version = item
                            });
                            break;
                        }
                    case 10:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android Lollipop — версия мобильной операционной системы Android. Представлена публике 25 июня 2014 года и выпущена в виде бета-версии для некоторых моделей серии Google Nexus под названием Android L. Официальный выход состоялся 3 ноября 2014 года[2]. Исходный код релизной версии был предоставлен производителям 4 ноября 2014 года[3].",
                                version = item
                            });
                            break;
                        }
                    case 11:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android Marshmallow — версия мобильной операционной системы Android, представленная на конференции Google I/O 28 мая 2015 года. В ней имеется ряд нововведений и функций, отличающих её от предшествующей Android Lollipop[3].",
                                version = item
                            });
                            break;
                        }
                    case 12:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android Nougat — седьмая версия мобильной операционной системы Android, разработанная Google. Финальный релиз операционной системы состоялся 22 августа 2016 года.[1][2] Название новой операционной системы было выбрано голосованием пользователей — Nougat, хотя многие ожидали Nutella[3].",
                                version = item
                            });
                            break;
                        }
                    case 13:
                        {
                            descriptions.Add(new Description
                            {
                                Text = $"Android Oreo — восьмая версия мобильной операционной системы Android, релиз которой состоялся 21 августа 2017 года[1][2]. В продолжение традиции, название версии представляет собой отсылку на кондитерское изделие: Oreo — популярный в США вид печенья.",
                                version = item
                            });
                            break;
                        }


                }


            }
            return descriptions;
        }

    }
}
