# CrossRealmPriceCheck

Cross Realm Price Check is a Tool that Utilizes the TradeSkillMaster API to check Item Prices against chosen realms.

# Usage

### Connecting

To Connect, enter your TSM API Key which can be found on your TSM Account Page (Link included on Connect Form).

### Adding and Removing Realms

To Add or Remove Realms from the Compare List, simply type the Realm Name and Click either Add or Remove. The program will correctly parse the Realm Name, so don't worry about spaces or capitals.

### Region

Simply check which Region you wish to scan. Only one may be selected at a time.

### Item ID

Now that Multiple Items are supported, you use the Item ID box exactly the same as the Realm Box, by adding and removing wanted Item IDs.

# Loading

## From File

You can now load the Realm List and Item ID list from File. Simply click load and choose your file.

## TSM Import

Item IDs can now also be imported from the TSM Group Maker or custom strings. Formatted as:
```
i:xxxxx;
```

Where `X` is the Item ID. You can import multiple Items at once using the same format.
```
i:xxxxx;i:xxxxx;i:xxxxx
```

# Saving

You can now directly save your own custom Realm and Item ID Lists, simply open the desired list window, and press Save To File.
