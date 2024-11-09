import axios from "axios"

const API_URL = "http://localhost:5250/api/Poll/";

export async function CreatePoll(Polls)
{
    try{
        const response = await axios.post(API_URL, Polls);
        return response.data
    } catch (error) {
        console.error(error);
    }
}

export async function GetPoll()
{
    try {
        const response = await axios.get(API_URL);
        return response.data;
    } catch (error) {
        console.error(error);
    }
}