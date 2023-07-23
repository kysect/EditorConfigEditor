# EditorConfig

## Какие проблемы / use cases

- Генерация документации к editorconfig (под документации из ms learn)
- Сравнение двух editorconfig
- Получение списка изменений, которые editorconfig привнесёт в солюшен
- Анализатор конфига - поиск отсутствующих, поиск не существующих значений/не валидные ключи или значения

## Задачи

- Автоматизировать генерацию документации к код-стайлу по editorconfig
  - Реализовать парсер editorconfig
  - Реализовать парсер документации из ms learn
  - Реализовать генератор файла документации
- Автоматизировать сравнение двух editorconfig файлов
  - Реализовать парсер editorconfig
  - Реализовать сравнение результата парсинга
  - Реализовать output в читаемом формате о diff'е между конфигурациями
- Реализовать возможность получить preview изменений от применений editorconfig'а
  - Найти способ с использованием Roslyn API получать превью изменений от применений правил
  - Интегрировать получение превью с Solution и editorconfig
  - Реализовать user friendly способ отображения собранных изменений
- Реализовать анализатор editorconfig файла
  - Найти способ получать список всех доступных правил, их значений
  - Реализовать алгоритм обхода editorconfig файла и проверки значений в нём

### Сценарии использования

- Работа с editorconfig файлом, который лежит:
  - Локально
  - На репозитории удалённо
- Работа с солюшеном, который лежит:
  - Локально
  - На репозитории удалённо
- Поддерживаемые форматы вывода данных:
  - Markdown

### Мысли на будущее

- Реализовать типизацию для правил на случай, если нужно будет реализовать модификацию editorconfig в коде

## Вопросы

- Как поставлять решение? Поставленные задачи не являются частью активной разработки и смысла делать расширения для IDE нет. Из вариантов: консольное приложение или минимальный десктоп UI.