interface ItemRepository {
    get(id: number): Item;
    save(item: Item);
}

interface Item {
    id: number;
    name: string;
}

class AbbreviationItemService {
    private r: ItemRepository
    constructor(r: ItemRepository) {
        this.r = r;
    }

    updateItemName(id: number, name: string) {
        const i = this.r.get(id);
        i.name = name;
        this.r.save(i);
    }
}

class FullNameItemService {
    private itemRepository: ItemRepository
    constructor(itemRepository: ItemRepository) {
        this.itemRepository = itemRepository;
    }

    updateItemName(id: number, newName: string) {
        const itemToUpdate = this.itemRepository.get(id);
        itemToUpdate.name = newName;
        this.itemRepository.save(itemToUpdate);
    }
}
