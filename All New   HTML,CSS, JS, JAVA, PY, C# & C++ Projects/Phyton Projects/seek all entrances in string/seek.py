main_string = 'abacabadaba'
target_string = 'aba'

seek_index = 0
result = []
while not seek_index == -1:
    seek_index = main_string.find(target_string, seek_index)
    if not seek_index == -1:
        result.append(seek_index)
        seek_index += 1
        
print(-1 if len(result) == 0 else result)