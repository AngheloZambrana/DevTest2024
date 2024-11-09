import axios from "axios"

const API_URL = "http://localhost:5250/api/Vote/";

export async function CreateVote(Vote)
{
    try {
        const response = await axios.post(API_URL, Vote);
        return response.data;
    } catch (error) {
        console.error(error);
    }
}